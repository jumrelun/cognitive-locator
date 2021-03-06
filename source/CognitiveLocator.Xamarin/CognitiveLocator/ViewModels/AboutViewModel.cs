﻿using CognitiveLocator.Interfaces;
using Xamarin.Forms;

namespace CognitiveLocator.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command SendFeedbackCommand { get; set; }

        public AboutViewModel() : this(new DependencyServiceBase())
        {
        }

        public AboutViewModel(IDependencyService dependencyService) : base(dependencyService)
        {
            DependencyService = dependencyService;
            InitializeViewModel();
        }

        private void InitializeViewModel()
        {
            Title = "Acerca de Busca.me";
            SendFeedbackCommand = new Command(() => SendEmailFeedback());
        }

        private void SendEmailFeedback()
        {
            DependencyService.Get<IEmailService>().SendEmail("rcervantes@outlook.com", "Comentario sobre Busca.me");
        }
    }
}