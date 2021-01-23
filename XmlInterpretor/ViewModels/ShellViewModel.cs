using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApplication.Controller;
using WpfApplication.Models;

namespace WpfApplication.ViewModels {
    public class ShellViewModel : BaseViewModel {
        private readonly XmlController _xmlController;

        #region TrackingObjectList
        private ObservableCollection<TrackingObjectModel> _TrackingObjectList;
        public ObservableCollection<TrackingObjectModel> TrackingObjectList {
            get => _TrackingObjectList;
            set {
                if (_TrackingObjectList != value) {
                    _TrackingObjectList = value;
                    OnPropertyChanged(nameof(TrackingObjectList));
                }

            }
        }
        #endregion

        #region SelectedTrackingObject
        private TrackingObjectModel _SelectedTrackingObject;
        public TrackingObjectModel SelectedTrackingObject {
            get => _SelectedTrackingObject;
            set {
                if (_SelectedTrackingObject != value) {
                    _SelectedTrackingObject = value;
                    OnPropertyChanged(nameof(SelectedTrackingObject));
                }
            }
        }
        #endregion

        #region Commands
        public ICommand AddFileCommand { get; set; }
        #endregion

        #region Constructor
        public ShellViewModel() {
            _xmlController = new XmlController();
            _TrackingObjectList = new ObservableCollection<TrackingObjectModel>();
            AddFileCommand = new RelayCommand(async () => await AddFileClickedAsync());
        }
        #endregion

        private async Task GetXmlDataFromFileAsync(string filePath) {
            if (string.IsNullOrEmpty(filePath)) {
                throw new ArgumentException($"'{nameof(filePath)}' cannot be null or empty", nameof(filePath));
            }

            try {
                var result = await _xmlController.GetAllXmlData(filePath);
                if (result.DataContent != null) {
                    foreach (var item in result.DataContent.TrackingList) {
                        TrackingObjectList.Add(item);
                    }
                } else {
                    MessageBox.Show($"Data from '{filePath}' is not in the correct format", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        #region ButtonClickedMethods
        private async Task AddFileClickedAsync() {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Xml files (*.xml)| *.xml";
            if (openFileDialog.ShowDialog() == true) {
                await GetXmlDataFromFileAsync(openFileDialog.FileName);
            }
        }
        #endregion
    }
}
