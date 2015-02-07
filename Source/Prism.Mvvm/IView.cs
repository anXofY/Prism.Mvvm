// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
namespace Microsoft.Practices.Prism.Mvvm
{
    [Obsolete("IView is no longer required in order to use the ViewModelLocator.")]
    public interface IView
    {
        object DataContext { get; set; }
    }
}
