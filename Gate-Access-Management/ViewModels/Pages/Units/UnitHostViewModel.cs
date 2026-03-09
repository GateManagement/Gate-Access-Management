using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gate_Access_Management.ViewModels.Pages.Units;

public partial class UnitHostViewModel : ViewModelBase
{
    public UnitListViewModel List { get; } = new();
    public UnitCreateViewModel Create { get; } = new();
    public UnitDetailsViewModel Details { get; } = new();

    [ObservableProperty] private ViewModelBase _currentView;

    public bool ShowBackButton => CurrentView != List;
    public bool ShowCreateButton => CurrentView == List;

    public UnitHostViewModel()
    {
        _currentView = List;
    }

    public void ShowDefault()
    {
        CurrentView = List;
    }

    partial void OnCurrentViewChanged(ViewModelBase value)
    {
        OnPropertyChanged(nameof(ShowBackButton));
        OnPropertyChanged(nameof(ShowCreateButton));
    }

    [RelayCommand]
    private void ShowList() => CurrentView = List;

    [RelayCommand]
    private void ShowCreate() => CurrentView = Create;

    [RelayCommand]
    private void ShowDetails() => CurrentView = Details;
}