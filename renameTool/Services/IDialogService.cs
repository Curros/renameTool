namespace renameTool.Services
{
    internal interface IDialogService
    {
        Task<bool> DisplayAlert(string title, string message, string accept, string cancel);

        Task DisplayAlert(string title, string message, string cancel);
    }
}
