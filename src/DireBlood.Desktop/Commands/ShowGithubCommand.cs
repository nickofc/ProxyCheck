﻿using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using DireBlood.Core.Abstractions;
using DireBlood.Core.Factory;
using DireBlood.Properties;
using MahApps.Metro.Controls.Dialogs;

namespace DireBlood.Commands
{
    public class ShowGithubCommand : ICommandFactory
    {
        private readonly object context;
        private readonly IDialogCoordinator dialogCoordinator;

        public ShowGithubCommand(object context, IDialogCoordinator dialogCoordinator)
        {
            this.context = context;
            this.dialogCoordinator = dialogCoordinator;
        }

        public ICommand Get()
        {
            return new RelayCommand(async () => await ShowGithubInfoAsync());
        }

        private async Task ShowGithubInfoAsync()
        {
            var dialogResult = await dialogCoordinator.ShowMessageAsync(context, Resources.Title, Resources.Redir,
                MessageDialogStyle.AffirmativeAndNegative, MetroDialogSettingsFactory.Get());

            if (dialogResult == MessageDialogResult.Affirmative) Process.Start("http://github.com/nickofc/");
        }
    }
}