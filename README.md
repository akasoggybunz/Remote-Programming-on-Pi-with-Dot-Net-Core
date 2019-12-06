# Remote Programming on Pi with Dot Net Core 3.1
Instructions and Code sets for Programming on a Raspberry Pi using Dot Net Core 3.1 and the IOT Nuget


## Prerequisites
- [Raspberry Pi](https://www.raspberrypi.org)
- [Visual Studio Code](https://code.visualstudio.com/download)
- [Etcher](https://www.balena.io/etcher/)
- SSH Client
       - [PuTTY](https://www.chiark.greenend.org.uk/~sgtatham/putty/latest.html) (Windows)

## Generate SSH Key
### Windows
1. Open Command Prompt. (Windows Key -> cmd -> enter)
2. Type `ssh-keygen`
3. Follow Instructions in command prompt.
4. SSH key should be generated at `c:/Users/{Username}/.ssh/id_rsa.pub`. 
5. Copy `id_rsa.pub` to Raspberry Pi. (Just on the SD card)

### Linux
1. Open Terminal
2. Type `ssh-keygen`  (If this command isn't found install openSSH for your distro)
3. Default file name is id_rsa.pub
4. Copy this to Pi

## Prepare Pi (Headless Operation)
1. Download [Rasbian](https://www.raspberrypi.org/downloads/raspbian/) I used Rasbian Buster Lite, you can pick which ever distro you prefer.
2. Use Etcher to Install Rasbian to SD Card.
3. Once Etcher is done. Create a new Text file name 'SSH' on the SD card.
4. Copy SSH Key over to SD card. 
    - Jump to Creating SSH KEY section if you need to know how/where SSH key is.
5. Put SD card in Pi and Turn on.
    - Make sure you have an interent connection to the Pi. For ease of use I am going to connect Pi to LAN.
    - Get IP of PI. I use FING Android APP to find the I.P. Address of PI.

## Dot Net Core on PI

## Visual Studio Code

## Hello World





## References, Sources, and Useful Links
- https://github.com/dotnet/core/blob/master/samples/RaspberryPiInstructions.md
- https://www.techrepublic.com/blog/10-things/how-to-generate-ssh-keys-in-openssh-for-windows-10/
- https://www.hanselman.com/blog/VisualStudioCodeRemoteDevelopmentOverSSHToARaspberryPiIsButter.aspx
- https://pimylifeup.com/raspberry-pi-ssh-keys/ 
- https://stackoverflow.com/questions/31813080/windows-10-ssh-keys
