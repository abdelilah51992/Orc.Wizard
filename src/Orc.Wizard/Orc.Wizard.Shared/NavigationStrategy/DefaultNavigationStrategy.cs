﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Constants.cs" company="WildGums">
//   Copyright (c) 2008 - 2016 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Wizard
{
    using System.Collections.Generic;
    using System.Linq;
    using Catel;

    public class DefaultNavigationStrategy : INavigationStrategy
    {
        #region Methods
        public int GetIndexOfNextPage(IWizard wizard)
        {
            Argument.IsNotNull(() => wizard);

            var pages = wizard.Pages.ToList();
            var currentPage = wizard.CurrentPage;
            if (currentPage == null)
            {
                var firstPage = pages.FirstOrDefault();
                if (firstPage == null)
                {
                    return WizardConfiguration.CannotNavigate;
                }

                return 0;
            }

            var lastPage = pages.LastOrDefault();
            if (currentPage == lastPage)
            {
                return WizardConfiguration.CannotNavigate;
            }

            var indexOfCurrentPage = pages.IndexOf(currentPage);
            var indexOfNextPage = indexOfCurrentPage + 1;

            return indexOfNextPage;
        }

        public int GetIndexOfPreviousPage(IWizard wizard)
        {
            Argument.IsNotNull(() => wizard);

            var pages = wizard.Pages.ToList();
            var currentPage = wizard.CurrentPage;
            if (currentPage == null)
            {
                var lastPage = pages.LastOrDefault();
                if (lastPage == null)
                {
                    return WizardConfiguration.CannotNavigate;
                }

                var indexOfLastPage = pages.Count() - 1;
                return indexOfLastPage;
            }

            var firstPage = pages.FirstOrDefault();
            if (currentPage == firstPage)
            {
                return WizardConfiguration.CannotNavigate;
            }

            var indexOfCurrentPage = pages.IndexOf(currentPage);
            var indexOfPreviousPage = indexOfCurrentPage - 1;

            return indexOfPreviousPage;
        }
        #endregion
    }
}