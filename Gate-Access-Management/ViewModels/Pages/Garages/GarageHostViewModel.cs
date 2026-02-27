using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gate_Access_Management.ViewModels.Pages.Garages;

public partial class GarageHostViewModel : ViewModelBase
{
    public GarageListViewModel List { get; } = new();
    public GarageCreateViewModel Create { get; } = new();
    public GarageDetailsViewModel Details { get; } = new();

    [ObservableProperty]
    private ViewModelBase _currentView;

    public GarageHostViewModel()
    {
        _currentView = List;
    }

    [RelayCommand]
    private void ShowList() => CurrentView = List;

    [RelayCommand]
    private void ShowCreate() => CurrentView = Create;

    [RelayCommand]
    private void ShowDetails() => CurrentView = Details;
}