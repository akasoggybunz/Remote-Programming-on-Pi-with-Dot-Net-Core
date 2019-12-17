# Remote Programming on Raspberry Pi with Dot Net Core 3.1
Instructions and Code sets for Programming on a Raspberry Pi using Dot Net Core 3.1 and the IOT Nuget

## Prerequisites
- [Raspberry Pi](https://www.raspberrypi.org)
       - Pi MUST be a model 2, 3, or 4 +. 
        Note: All models of generation 1 and Pi Zero are not supported because the .NET Core JIT depends on armv7 instructions not available on those versions. [reference](https://github.com/dotnet/core/blob/master/samples/RaspberryPiInstructions.md)
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
- SSH into the Raspberry Pi

### Installing .NET Core Globally

The following instructions install .NET Core globally. It isn't required to do that, but it provides the best experience.

```console
sudo apt-get update && sudo apt-get upgrade -y
sudo apt-get install curl libunwind8 gettext apt-transport-https
curl -SL -o dotnet.tar.gz https://download.visualstudio.microsoft.com/download/pr/8c839c0e-a5ae-4254-8d8b-c012528fe601/c147e26bad68f97eacc287a71e01331d/aspnetcore-runtime-3.1.0-linux-arm.tar.gz
sudo mkdir -p /usr/share/dotnet
sudo tar -zxf dotnet.tar.gz -C /usr/share/dotnet
sudo ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet
```
### Installing .Net Core Locally
If you don't want to install Globally or the above didn't work try the following.
```console
sudo apt-get update && sudo apt-get upgrade -y
sudo apt-get install curl libunwind8 gettext apt-transport-https
wget https://download.visualstudio.microsoft.com/download/pr/67766a96-eb8c-4cd2-bca4-ea63d2cc115c/7bf13840aa2ed88793b7315d5e0d74e6/dotnet-sdk-3.1.100-linux-arm.tar.gz
mkdir -p $HOME/dotnet && tar zxf dotnet-sdk-3.1.100-linux-arm.tar.gz -C $HOME/dotnet
export DOTNET_ROOT=$HOME/dotnet
export PATH=$PATH:$HOME/dotnet
```
#### Allow Dot Net Commands after this terminal session is over
```console
sudo nano ~/.bash_profile, ~/.bashrc
```
- Add to end of file `export PATH=$PATH:$HOME/dotnet` 
- Add to next line `export DOTNET_ROOT=$HOME/dotnet`

```console
`ctrl+x` -> `y` -> `enter`
sudo apt-get update
```

### Test Dot Net Commands
```console
dotnet --version
```
- This should tell you the version of dotnet.
- If this did not work there was an error. Please look over the instructions and make sure you didn't miss anything. If you feel you have done everything correctly please submit an issue.

## Visual Studio Code
Note: Much of this is taken from [Hanselman.com](https://www.hanselman.com/blog/VisualStudioCodeRemoteDevelopmentOverSSHToARaspberryPiIsButter.aspx)
1. Install the [Remote Development Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.vscode-remote-extensionpack).
       - Click on Extensions on the Left Hand side
       - In the 'Search Extensions in Marketplace' type `Remote Development`
       - Install
 2. `ctrl+p`
 3. `Remote-SSH` in Textbox on top
 4. click `Remote-SSH: Connect to Host`
 5. TODO will add more documentation soon.

## Hello World - INCOMPLETE NEEDS WORK
Once Connected to Raspberry Pi with Remote-SSH within Visual Studio. We can remotely develop.
1. Use Git to Get the code `sudo git https://github.com/akasoggybunz/Remote-Programming-on-Pi-with-Dot-Net-Core/tree/master/code/Blink%20LED`
2. Build & Publish `dotnet publish -r linux-arm`
3. Run Code in publish directory `./code`



## References, Sources, and Useful Links
- https://github.com/dotnet/core/blob/master/samples/RaspberryPiInstructions.md
- https://www.hanselman.com/blog/InstallingTheNETCore2xSDKOnARaspberryPiAndBlinkingAnLEDWithSystemDeviceGpio.aspx
- https://gist.github.com/richlander/467813274cea8abc624553ee72b28213
- https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-3.1.100-linux-arm32-binaries
- https://www.techrepublic.com/blog/10-things/how-to-generate-ssh-keys-in-openssh-for-windows-10/
- https://www.hanselman.com/blog/VisualStudioCodeRemoteDevelopmentOverSSHToARaspberryPiIsButter.aspx
- https://pimylifeup.com/raspberry-pi-ssh-keys/ 
- https://stackoverflow.com/questions/31813080/windows-10-ssh-keys
- https://en.wikipedia.org/wiki/Raspberry_Pi

## Footer
[![ForTheBadge built-with-love](http://ForTheBadge.com/images/badges/built-with-love.svg)](https://GitHub.com/akasoggybunz/)
[![Badge for version for Visual Studio Code extension naereen.makefiles-support-for-vscode](https://vsmarketplacebadge.apphb.com/version/naereen.makefiles-support-for-vscode.svg)](https://marketplace.visualstudio.com/items?itemName=naereen.makefiles-support-for-vscode)
