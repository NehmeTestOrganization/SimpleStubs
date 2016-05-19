﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestClassLibrary
{
    public interface IAppConfigPeriodicRefreshHandler : IDisposable
    {
        void Start();
    }

    public interface IPhoneBook
    {
        long GetContactPhoneNumber(string firstName, string lastName);

        long MyNumber { get; set; }

        int ContactsCount { get; }

        event EventHandler<long> PhoneNumberChanged;
    }

    

    public interface ITestInterface : IDisposable
    {
        void DoSomething(string s, int x);

        void DoSomething(List<IEnumerable<string>> list);

        void DoSomething(string[] array);

        Task<List<int>> DoSomething(int parameter);

        string Prop1 { get; }

        string Prop2 { set; }

        string Prop3 { get; set; }

        event EventHandler<EventArgs> Changed;

	    event EventHandler OtherEvent;

        List<T> GetGenericList<T, A>();

        void SetGenericValue<T>(T value);
    }

    public interface IIgnoredInterface : IDisposable
    {
    }

    interface IInternalInterface
    {
        void DoSomethingInternal();
    }

    public interface IGenericInterface<T>
    {
        T GetX();
    }

}
