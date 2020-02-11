using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualAcademy.Pages
{
    public partial class About : ComponentBase
    {
        private string Title =string.Empty;

        public string Subtitle { get; set; } = "사이트 정보";

        protected override void OnInitialized()
        {
            Title = "정보";
            Subtitle = DateTime.Now.ToLongTimeString();
        }
    }
}
