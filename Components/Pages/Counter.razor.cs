using Microsoft.AspNetCore.Components;

namespace BlazorTestApp.Components.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private string message = "";

        private string inputMessage = "";

        private string divText = "Kukkuu";

        protected override void OnInitialized()
        {
            currentCount = InitialCount;
        }
        [Parameter]
        public int InitialCount { get; set; }

        private void IncrementCount()
        {
            currentCount++;
        }

        async Task IncrementCountAsync()
        {
            await Task.Delay(1000);
            currentCount++;
        }
        private void Increment(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            message = "X pos: " + e.ClientX.ToString() + " Y pos: " + e.ClientY.ToString(); 
            currentCount++;
        }
        private void OnInput(ChangeEventArgs e)
        {
            inputMessage = e.Value?.ToString() ?? "";
        }
        private void OnMouseOver(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            divText = $"Mouse is now at x: {e.OffsetX}, y: {e.OffsetY} ";
        }

        private void OnMouseOut(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            divText = "Mouse left the room";
        }
    }
}