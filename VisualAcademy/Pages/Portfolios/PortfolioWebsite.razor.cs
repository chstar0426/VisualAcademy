using Microsoft.AspNetCore.Components;

namespace VisualAcademy.Pages.Portfolios
{
    public partial class PortfolioWebsite
    {
        [Inject]
        public NavigationManager NavigationManagerRef { get; set; }

        protected override void OnInitialized()
        {
            
        }

        protected void GotoDotNetKorea()
        {
            NavigationManagerRef.NavigateTo("/Index");

        }

    }
}
