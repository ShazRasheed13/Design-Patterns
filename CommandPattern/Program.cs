using CommandPattern;

RemoteControl remote = new RemoteControl();

Light light = new Light();
Stereo stereo = new Stereo();

ICommand lightOnCommand = new LightOnCommand(light);
ICommand stereoVolumeUpCommand = new StereoVolumeUpCommand(stereo);

remote.SetCommand(lightOnCommand);
remote.ButtonPressed();

remote.SetCommand(stereoVolumeUpCommand);
remote.ButtonPressed();