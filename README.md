# KinectPlugins
KinectDemoRoom  upgrade to 5.0.0

https://stackoverflow.com/questions/62493213/creating-a-new-class-c-in-unreal-with-visual-studio-gives-me-too-many-errors

Go to a VS solution folder. Delete following folders : ".vs", "Intermediate", "Saved"
Delete solution (*.sln file). Keep *.uproject
Right click on *.uproject in explorer, click "switch unreal engine versoin" and select your current engine version. Project files and solutions will get regenerated.
Open your vs solution. Your generated files will be missing, so hit "build" button.
Go to Tools->Options->Text editor->Advanced, set "Recreate Database" to "true" and restart visual studio

