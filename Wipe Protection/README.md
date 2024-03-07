Thsis is an modded version of Wipe Protection by FastBurst --> https://umod.org/plugins/wipe-protection

at line 61 i have added the subscribed method :

        private void OnWipeProtectStart()
        {
            DateTime now = DateTime.Now;
            DateTime rs = now.AddHours(configData.Settings.wipeprotecctime);
            storedData.wipeprotection = true;
            storedData.lastwipe = SaveRestore.SaveCreatedTime.ToString();
            storedData.RaidStartTime = rs.ToString();
            SaveFile();

            SendChatMessage("raid protection has Started.");

        }

This is a BY DATE timer and needs to be added to Dates entries of BigBen Json file.

    "WipeProtectStart": "16:15,01/06,02/06,03/06,04/06,05/06,06/06,07/06,08/06,09/06,10/06,11/06,12/06"


since Wipe Protection self completes, we dont need an event hook to end it.


        {
          "Timers (event name, event time)": {
            "Dawn": "07:00",
            "Noon": "12:00",
            "Dusk": "18:00",
            "Midnight": "00:00"
          },
          "Dates (event name, event date/time)": {
            "WipeProtectStart": "16:15,01/06,02/06,03/06,04/06,05/06,06/06,07/06,08/06,09/06,10/06,11/06,12/06"
          }
        }

The above entry will trigger at 4:15pm on the 6th of each month.
