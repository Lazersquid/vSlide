# vSlide

This is a feeder aplication for vJoy, it enables you to alter the slider axis of a 
vJoy device in a number of different ways via your Keyboard.

Setup vSlide
-
- Download and install vJoy

http://vjoystick.sourceforge.net/site/index.php/download-a-install/72-download
- Download the latest vSlide build (Version 1.2) from the 'Builds' folder

https://github.com/Lazersquid/vSlide/raw/master/Builds/vSlide_v.1.2.zip
- Unzip the downloaded vSlide build
- Run the executable and click the instructions tab at the top
- Bind your collective to the vJoy device using the explanation below

Remove vSlide
-
- Delete the unziped vSlide build
- Navigate to "%appdata%/../Local"
- Delete the vSlide directory (it should only contain a *.config file)

Note: The directory in "%appdata%/../Local" only exists if you saved your vSlide settings

How to bind the vJoy slider to Arma3's 'Collective raise(analogue)' & 'Collective lower(analogue)'?
-
- Press the 'Start Feeding' Button  in the main window of vSlide if you haven't already
- Check the 'Do Ping Pong Lerping' checkbox in the main window of vSlide
- The slider value should now be lerping from 0% to 100% and back again
- Go into the Arma3 control menu
- Click the 'Collective raise(analogue)' keybinding
- Now wait for Arma3 to detect 'vjoy device Stick Slider 1+'.
- Press ok.
- Click the 'Collective lower(analogue)' keybinding
- Now wait for Arma3 to detect 'vjoy device Stick Slider 1-'
- Press ok again
- Assure that 'Collective raise(analogue)' is only bound to 'vjoy device Stick Slider 1+'
- And that 'Collective lower(analogue)' is only bound to 'vjoy device Stick Slider 1-'
- Uncheck the 'Do Ping Pong Lerping' in the main window of vSlide
- Everything should work now
