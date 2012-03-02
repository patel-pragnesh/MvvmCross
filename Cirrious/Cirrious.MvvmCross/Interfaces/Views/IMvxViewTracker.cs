#region Copyright

// <copyright file="IMvxViewTrcaker.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
// 
// Author - Stuart Lodge, Cirrious. http://www.cirrious.com

#endregion

namespace Cirrious.MvvmCross.Interfaces.Views
{
    public interface IMvxViewTracker
    {
        void RegisterView(IMvxView view);
        void UnRegisterView(IMvxView view);
    }
}