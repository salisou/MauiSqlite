using Bogus;
using MauiSqlite.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiSqlite.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewmodel
    {
        public List<Customer> Customers {  get; set; }
        public Customer CurrentCustomer { get ; set; }

        public ICommand AddOrUpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public MainPageViewmodel()
        {
            var orders = App.OrdersRepo.GetItems();

            Refrech();
            GenerateNewCustomer();

            AddOrUpdateCommand = new Command(() =>
            {
                //App.CustomerRepo.SaveItem(CurrentCustomer);
                App.CustomerRepo.SaveItemWhitChildern(CurrentCustomer);
                Console.WriteLine(App.CustomerRepo.StatusMesage);
                GenerateNewCustomer();
                Refrech();
            });

            DeleteCommand = new Command(() =>
            {
                App.CustomerRepo.DeleteItem(CurrentCustomer);
                Refrech();
            });
        }

        private void GenerateNewCustomer()
        {
            CurrentCustomer = new Faker<Customer>()
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Address, f => f.Person.Address.Street)
                .Generate();

            CurrentCustomer.Passport = new List<Passport>
            {
                new Passport
                {
                    ExpirationDate = DateTime.Now.AddDays(30),
                },
                
                new Passport
                {
                    ExpirationDate = DateTime.Now.AddDays(15),
                }
            };
        }

        private void Refrech()
        {
            //Customers = App.CustomerRepo.GetItems();
            Customers = App.CustomerRepo.GetItemsWihtChildern();
            //Customers = App.CustomerRepo.GetAll(x => x.Name.StartsWith("A"));
            var passpor = App.CustomerRepo.GetItems();
        }
    }
}
