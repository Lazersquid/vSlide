# vSlide

This is a feeder aplication for vJoy, it enables you to alter the slider axis of a 
vJoy device in a number of different ways via your Keyboard.

Setup vSlide
-
- Download and install vJoy

http://vjoystick.sourceforge.net/site/index.php/download-a-install/72-download
- Download the latest vSlide build (Version 1.1) from the 'Builds' folder

https://github.com/Lazersquid/vSlide/raw/master/Builds/vSlide_v.1.1.zip
- Unzip the downloaded vSlide build
- Run the executable and click the instructions tab at the top

Remove vSlide
-
- Delete the unziped vSlide build
- Navigate to "%appdata%/../Local"
- Delete the vSlide directory (it should only contain a *.config file)

Note: The directory in "%appdata%/../Local" only exists if you saved your vSlide settings

How to bind the vJoy axis to Arma3's 'Collective raise(analogue)' & 'Collective lower(analogue)'?
-
- The following steps all focus on the startup window that opens when you start vSlide
- Press the 'Start Feeding' Button if you haven't already
- Check the 'Do Ping Pong Lerping' Checkbox
- The slider value will no be lerping from 0% to 100% and back again
- Go into the Arma3 control menu
- Click the 'Collective raise(analogue)'
- Now wait for Arma3 to detect 'vjoy device Stick Slider 1+'.
- Press ok.
- Click the 'Collective lower(analogue)'
- Now wait for Arma3 to detect 'vjoy device Stick Slider 1-'
- Now press ok again.
- Uncheck the 'Do Ping Pong Lerping'
- Everything should work now
