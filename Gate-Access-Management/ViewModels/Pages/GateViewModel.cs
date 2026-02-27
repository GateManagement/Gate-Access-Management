using CommunityToolkit.Mvvm.Input;
using System;

namespace Gate_Access_Management.ViewModels.Pages;

public partial class GateViewModel : ViewModelBase
{
    [RelayCommand]
    private void OpenEntryGate()
    {
        Console.WriteLine("Entry gate opened");
    }

    [RelayCommand]
    private void CloseEntryGate()
    {
        Console.WriteLine("Entry gate closed");
    }

    [RelayCommand]
    private void HoldOpenEntryGate()
    {
        Console.WriteLine("Entry gate hold open");
    }

    [RelayCommand]
    private void OpenExitGate()
    {
        Console.WriteLine("Exit gate opened");
    }

    [RelayCommand]
    private void CloseExitGate()
    {
        Console.WriteLine("Exit gate closed");
    }

    [RelayCommand]
    private void HoldOpenExitGate()
    {
        Console.WriteLine("Exit gate hold open");
    }
}