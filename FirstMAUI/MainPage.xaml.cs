using System.Collections.ObjectModel;
using Robots;


namespace FirstMAUI;

public partial class MainPage : ContentPage
{
	//using Robot;

	string Name = null;
	int Size = 0;
	string Type = null;
	List<string> TypeList = new List<string> { "Droïde de protocole", "Droïde astromécane" }; 
	ObservableCollection<Robot> robotList = new ObservableCollection<Robot>();

	public MainPage()
	{
		InitializeComponent();
	}

	private void AddRobotToList(object sender, EventArgs e)
	{
		robotList.Add(new Robot(Size, Name, Type)); 
	}
}


