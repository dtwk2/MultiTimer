﻿using System.Reactive.Disposables;
using ReactiveUI;

namespace MultiTimer
{
    public partial class TimerView : ReactiveUserControl<TimerViewModel>
    {
        public TimerView()
        {
            InitializeComponent();
            this.WhenActivated(disposable =>
            {
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Name,
                        view => view.Name.Text)
                    .DisposeWith(disposable);
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Hours,
                        view => view.Hours.Text,
                        value => value.ToString())
                    .DisposeWith(disposable);
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Minutes,
                        view => view.Minutes.Text,
                        value => value.ToString())
                    .DisposeWith(disposable);
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Seconds,
                        view => view.Seconds.Text,
                        value => value.ToString())
                    .DisposeWith(disposable);
            });
        }
    }
}
