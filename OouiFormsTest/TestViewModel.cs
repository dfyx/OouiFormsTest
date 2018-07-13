

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OouiFormsTest
{
    public class TestViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TestObject> TestObjects { get; } = new ObservableCollection<TestObject>();

        public event PropertyChangedEventHandler PropertyChanged;

        public TestViewModel()
        {
            TestObjects.Add(new TestObject { Name = "Hello" });
            TestObjects.Add(new TestObject { Name = "World" });
        }
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}