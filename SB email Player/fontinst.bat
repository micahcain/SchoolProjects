Rem fontinst.bat
copy unrealT.ttf %systemroot%\fonts
regedit /s unreal.reg
copy MCI32.ocx %systemroot%
copy anigif.ocx %systemroot%
copy flash.ocx %systemroot%
regedit /s MCI32.ocx
regedit /s anigif.ocx
regedit /s flash.ocx