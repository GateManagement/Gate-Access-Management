using System;
using CommunityToolkit.Mvvm.Input;

namespace Gate_Access_Management.ViewModels.Pages;

public partial class LogsViewModel : ViewModelBase
{
    [RelayCommand]
    private void ExportLogs()
    {
        Console.WriteLine("Exporting Logs");
    }
}