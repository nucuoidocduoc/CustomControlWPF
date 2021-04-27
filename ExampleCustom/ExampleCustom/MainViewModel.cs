using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ExampleCustom
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Action<Guid> _zoom;
        private Action<Guid> _show3D;
        private ObservableCollection<ClashViewModel> _clashes = new ObservableCollection<ClashViewModel>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public MainViewModel()
        {
        }

        public MainViewModel(List<ClashModel> clashes, Action<Guid> zoom, Action<Guid> show3D)
        {
            _zoom = _ => MessageBox.Show("zoom");
            _show3D = _ => MessageBox.Show("show3d");
            //_zoom = zoom;
            //_show3D = show3D;
            clashes = new List<ClashModel> {
               new ClashModel {
                   Id = Guid.NewGuid(),
                   ClashTitle="ClashTitle",
                   Tolerance="Tolerance|Clash1",
                   ClashName = "ClashName",
                   GridLocation = "GridLocation",
                   DateFound = "DateFound",
                   Status = "Active",
                   LastUpdate = "LastUpdate",
                   UpdateInfo = "UpdateInfo",

                   ElementId1 = "ElementId1",
                   Layer1 = "Layer1",
                   ItemType1 = "ItemType1",
                   ItemName1 = "ItemName1",
                   Path1 = "Path1",

                   ElementId2 = "ElementId2",
                   Layer2 = "Layer2",
                   ItemType2 = "ItemType2",
                   ItemName2 = "ItemName2",
                   Path2 = "Path2"
               },
               new ClashModel {
                   Id = Guid.NewGuid(),
                   ClashTitle="ClashTitle2",
                   Tolerance="Tolerance|Clash2",
                   ClashName = "ClashName2",
                   GridLocation = "GridLocation",
                   DateFound = "DateFound",
                   Status = "Pendding",
                   LastUpdate = "LastUpdate",
                   UpdateInfo = "UpdateInfo",

                   ElementId1 = "ElementId1",
                   Layer1 = "Layer1",
                   ItemType1 = "ItemType1",
                   ItemName1 = "ItemName1",
                   Path1 = "Path1",

                   ElementId2 = "ElementId2",
                   Layer2 = "Layer2",
                   ItemType2 = "ItemType2",
                   ItemName2 = "ItemName2",
                   Path2 = "Path2"
               },
                new ClashModel {
                   Id = Guid.NewGuid(),
                   ClashTitle="ClashTitle2",
                   Tolerance="Tolerance|Clash2",
                   ClashName = "ClashName2",
                   GridLocation = "GridLocation",
                   DateFound = "DateFound",
                   Status = "Finished",
                   LastUpdate = "LastUpdate",
                   UpdateInfo = "UpdateInfo",

                   ElementId1 = "ElementId1",
                   Layer1 = "Layer1",
                   ItemType1 = "ItemType1",
                   ItemName1 = "ItemName1",
                   Path1 = "Path1",

                   ElementId2 = "ElementId2",
                   Layer2 = "Layer2",
                   ItemType2 = "ItemType2",
                   ItemName2 = "ItemName2",
                   Path2 = "Path2"
               },
                new ClashModel {
                   Id = Guid.NewGuid(),
                   ClashTitle="ClashTitle2",
                   Tolerance="Tolerance|Clash2",
                   ClashName = "ClashName2",
                   GridLocation = "GridLocation",
                   DateFound = "DateFound",
                   Status = "Reviewed",
                   LastUpdate = "LastUpdate",
                   UpdateInfo = "UpdateInfo",

                   ElementId1 = "ElementId1",
                   Layer1 = "Layer1",
                   ItemType1 = "ItemType1",
                   ItemName1 = "ItemName1",
                   Path1 = "Path1",

                   ElementId2 = "ElementId2",
                   Layer2 = "Layer2",
                   ItemType2 = "ItemType2",
                   ItemName2 = "ItemName2",
                   Path2 = "Path2"
               }
           };
            InitClash(clashes);
        }

        private void InitClash(List<ClashModel> clashes)
        {
            foreach (var clash in clashes) {
                _clashes.Add(new ClashViewModel(_zoom, _show3D) {
                    Id = clash.Id,
                    ClashTitle = clash.ClashTitle,
                    Tolerance = clash.Tolerance,
                    ClashName = clash.ClashName,
                    GridLocation = clash.GridLocation,
                    DateFound = clash.DateFound,
                    Status = clash.Status,
                    LastUpdate = clash.LastUpdate,
                    UpdateInfo = clash.UpdateInfo,

                    ElementId1 = clash.ElementId1,
                    Layer1 = clash.Layer1,
                    ItemType1 = clash.ItemType1,
                    ItemName1 = clash.ItemName1,
                    Path1 = clash.Path1,

                    ElementId2 = clash.ElementId2,
                    Layer2 = clash.Layer2,
                    ItemType2 = clash.ItemType2,
                    ItemName2 = clash.ItemName2,
                    Path2 = clash.Path2
                });
            }
        }

        public ObservableCollection<ClashViewModel> Clashes
        {
            get => _clashes;
            set
            {
                if (_clashes != value) {
                    _clashes = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}