using System;
using System.Windows.Input;

namespace ExampleCustom
{
    public class ClashViewModel : ClashModel
    {
        private readonly Action<Guid> _zoom;
        private readonly Action<Guid> _show3D;

        public ClashViewModel(Action<Guid> zoom, Action<Guid> show3D)
        {
            _zoom = zoom;
            _show3D = show3D;

            ZoomCommand = new RelayCommand<object>(ZoomCommandInvoke);
            Show3DCommand = new RelayCommand<object>(Show3DCommandInvoke);
        }

        public ICommand ZoomCommand { get; set; }

        private void ZoomCommandInvoke(object sender)
        {
            _zoom.Invoke(Id);
        }

        public ICommand Show3DCommand { get; set; }

        private void Show3DCommandInvoke(object sender)
        {
            _show3D.Invoke(Id);
        }
    }
}