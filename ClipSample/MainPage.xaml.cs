using Microsoft.Maui.Controls.Shapes;

namespace ClipSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	
}

public class Customview : ContentView
{
	public Customview()
	{
		this.BackgroundColor = Colors.Red;
        this.Clip = new RoundRectangleGeometry(6, this.Bounds);
    }

   
}
