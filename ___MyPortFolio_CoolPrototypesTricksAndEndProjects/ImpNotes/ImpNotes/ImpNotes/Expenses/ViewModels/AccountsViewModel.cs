﻿using System;
using System.Collections.ObjectModel;
using ImpNotes.Models;
using ImpNotes.Services;
using ImpNotes.ViewModels;

namespace ImpNotes.Expenses.ViewModels
{
    public class AccountsViewModel :BaseViewModel
    {

        private ObservableCollection<Account> _accounts;
        public   ObservableCollection<Account> Accounts
        {
            get { return _accounts; }
            set { SetProperty(ref _accounts, value); }
        }

        public void Initilize()
        {
            try
            {
                var list = new DataService().GetList<Account>(false);

                Accounts = new ObservableCollection<Account>(list);
            }
            catch (Exception ex)
            {
                Accounts = new ObservableCollection<Account>();
            }

        }

    }
}
