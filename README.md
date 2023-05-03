# Fork Info

This is a MODIFIED FORK of the Marrow-ExtendedSDK, it contains fixed scripts which are functional at this time. (Patch 2 of BL). I didnt bother moving the folders that the scripts were in because I am incredibly lazy, but it doesnt matter, itll still work fine.

THIS ALSO INCLUDES PUPPETMASTER SCRIPTS. They're all dummy scripts, I believe they werent included in the original Extended SDK because of fear of the PuppetMaster people not being alright with it, but it should be fine considering all the scripts are empty anyway (Besides variable names and empty methods).

If you want to use this fork, delete your current "Marrow-ExtendedSDK" folder and download this one via the green code button up at the top. Then place it into your folder where the old Marrow-ExtendedSDK folder was. References should be completely fine and you shouldn't have any missing scripts. Although, since PuppetMaster scripts were added, some script references on NPCs will be MISSING! If you made an NPC prior to this, you should delete your puppetmaster/behavior/NPC dummy scripts that you used prior to this fork as there will be conflicts between the scripts.

# Info
This repository allows the extension of the BONELAB Marrow SDK, allowing you to create custom guns and other types of items not yet supported by the Marrow SDK.

One of the major objectives of this repo, is to remove incentives to decompile the game, through strategic inclusion of assets which aren't useful elsewhere, and thorough documentation of what's possible.

# How to Install

Follow steps 1-5 from the official SDK over at https://github.com/StressLevelZero/MarrowSDK/wiki#project-setup

In step 6, you'll want to import these three packages via github URL:

https://github.com/StressLevelZero/Custom-RenderPipelineCore.git

https://github.com/StressLevelZero/Custom-URP.git#Bonelab

https://github.com/notnotnotswipez/MarrowSDKExt.git

Using the green Code dropdown at the top of this page, download a zip of this repository, and unzip it's contents into your Assets folder to have Assets/Marrow-ExtendedSDK-PATCH-2

Continue following steps 7+ from the official SDK documentation.

### Check out the included Examples folder for ideas on how to create Guns and Levels.

# Disclaimer
Stress Level Zero's Official Bonelab SDK is MIT licenced, and by extension, so is all of this. Updates to the official SDK may break this repo at any time and there is no guaranteed support, so use at your own risk. With any luck, updates to the Official SDK will make this extension repo obsolete.

### This repo contains DUMMY scripts. Which are scripts that are not functional and contain no code. They simply get replaced with their ingame equivalents upon being loaded. It also contains some example pieces with simple (Blocky) art assets.

# IF YOU WOULD LIKE TO PR SOMETHING TO THIS REPO PLEASE FOLLOW THESE GUIDELINES:
### Do not PR any FUNCTIONAL/NON DUMMY scripts that come from paid asset packs/utilities. Dummy scripts are fine. Functional and FREE open source/public scripts are fine.
### Do not PR any art that must be paid for or was paid for by someone. This includes assets ripped directly from Bonelab (PRs containing direct Bonelab assets will not be accepted). Only free assets or assets personally made and granted free open access by the creator are allowed. (This keeps things like the examples usable with no worry about copyright)

# Credits and Attributions
Kairus101, RevOcelotMGS, dotbenj, goodboy10 - Original ExtendedSDK which this fork is based on. <br>
yellowyears - Replaced dummy Navmesh scripts with their functional counterparts. Deleted duplicate Spline Joint scripts. <br>
notnotnotswipez - Current maintainer/updater of this fork of the ExtendedSDK.
