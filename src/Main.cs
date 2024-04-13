using Godot;

public partial class Main : Node3D
{
	private XRInterface _xrInterface;

	public override void _Ready()
	{
		_xrInterface = XRServer.FindInterface("OpenXR");
		if(_xrInterface != null && _xrInterface.IsInitialized())
		{
			GD.Print("OpenXR initialized successfully");

			// Turn off v-sync!
			DisplayServer.WindowSetVsyncMode(DisplayServer.VSyncMode.Disabled);

			var viewPort = GetViewport();
			// Change our main viewport to output to the HMD
			viewPort.UseXR = true ;

		}
		else
		{
			GD.Print("OpenXR not initialized, please check if your headset is connected");
		}
	}
	
	 // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
