﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CGM.Communication.MiniMed.Infrastructur
{
    public enum EventTypeEnum : byte
    {
        TIME_RESET = 0x02,
        USER_TIME_DATE_CHANGE = 0x03,
        SOURCE_ID_CONFIGURATION = 0x04,
        NETWORK_DEVICE_CONNECTION = 0x05,
        AIRPLANE_MODE = 0x06,
        START_OF_DAY_MARKER = 0x07,
        END_OF_DAY_MARKER = 0x08,
        PLGM_CONTROLLER_STATE = 0x0B,
        NORMAL_BOLUS_PROGRAMMED = 0x15,
        SQUARE_BOLUS_PROGRAMMED = 0x16,
        DUAL_BOLUS_PROGRAMMED = 0x17,
        CANNULA_FILL_DELIVERED = 0x1A,
        TEMP_BASAL_PROGRAMMED = 0x1B,
        BASAL_PATTERN_SELECTED = 0x1C,
        BASAL_SEGMENT_START = 0x1D,
        INSULIN_DELIVERY_STOPPED = 0x1E,
        INSULIN_DELIVERY_RESTARTED = 0x1F,
        SELF_TEST_REQUESTED = 0x20,
        SELF_TEST_RESULTS = 0x21,
        TEMP_BASAL_COMPLETE = 0x22,
        BOLUS_SUSPENDED = 0x24,
        SUSPENDED_BOLUS_RESUMED = 0x25,
        SUSPENDED_BOLUS_CANCELED = 0x26,
        BOLUS_CANCELED = 0x27,
        ALARM_NOTIFICATION = 0x28,
        ALARM_CLEARED = 0x2A,
        LOW_RESERVOIR = 0x2B,
        BATTERY_INSERTED = 0x2C,
        FOOD_MARKER = 0x2E,
        EXERCISE_MARKER = 0x2F,
        INJECTION_MARKER = 0x30,
        OTHER_MARKER = 0x31,
        BG_READING = 0x32,
        CODE_UPDATE = 0x33,
        MISSED_MEAL_BOLUS_REMINDER_EXPIRED = 0x34,
        REWIND = 0x36,
        BATTERY_REMOVED = 0x37,
        CALIBRATION_COMPLETE = 0x38,
        ACTIVE_INSULIN_CLEARED = 0x39,
        DAILY_TOTALS = 0x3C,
        BOLUS_WIZARD_ESTIMATE = 0x3D,
        USER_SETTINGS_SAVE = 0x50,
        USER_SETTINGS_RESETTO_DEFAULTSS = 0x51,
        OLD_BASAL_PATTERN = 0x52,
        NEW_BASAL_PATTERN = 0x53,
        OLD_PRESET_TEMP_BASAL = 0x54,
        NEW_PRESET_TEMP_BASAL = 0x55,
        OLD_PRESET_BOLUS = 0x56,
        NEW_PRESET_BOLUS = 0x57,
        MAX_BASAL_RATE_CHANGE = 0x58,
        MAX_BOLUS_CHANGE = 0x59,
        PERSONAL_REMINDER_CHANGE = 0x5A,
        MISSED_MEAL_BOLUS_REMINDER_CHANGE = 0x5B,
        BOLUS_INCREMENT_CHANGE = 0x5C,
        BOLUS_WIZARD_SETTINGS_CHANGE = 0x5D,
        OLD_BOLUS_WIZARD_INSULIN_SENSITIVITY = 0x5E,
        NEW_BOLUS_WIZARD_INSULIN_SENSITIVITY = 0x5F,
        OLD_BOLUS_WIZARD_INSULIN_TO_CARB_RATIOS = 0x60,
        NEW_BOLUS_WIZARD_INSULIN_TO_CARB_RATIOS = 0x61,
        OLD_BOLUS_WIZARD_BG_TARGETS = 0x62,
        NEW_BOLUS_WIZARD_BG_TARGETS = 0x63,
        DUAL_BOLUS_OPTION_CHANGE = 0x64,
        SQUARE_BOLUS_OPTION_CHANGE = 0x65,
        EASY_BOLUS_OPTION_CHANGE = 0x66,
        BG_REMINDER_OPTION_CHANGE = 0x68,
        BG_REMINDER_TIME = 0x69,
        AUDIO_VIBRATE_MODE_CHANGE = 0x6A,
        TIME_FORMAT_CHANGE = 0x6B,
        LOW_RESERVOIR_WARNING_CHANGE = 0x6C,
        LANGUAGE_CHANGE = 0x6D,
        STARTUP_WIZARD_START_END = 0x6E,
        REMOTE_BOLUS_OPTION_CHANGE = 0x6F,
        AUTO_SUSPEND_CHANGE = 0x72,
        BOLUS_DELIVERY_RATE_CHANGE = 0x73,
        DISPLAY_OPTION_CHANGE = 0x77,
        SET_CHANGE_REMINDER_CHANGE = 0x78,
        BLOCK_MODE_CHANGE = 0x79,
        BOLUS_WIZARD_SETTINGS_SUMMARY = 0x7B,
        SENSOR_SETTINGS_CHANGE = 0xC8,
        OLD_SENSOR_WARNING_LEVELS = 0xC9,
        NEW_SENSOR_WARNING_LEVELS = 0xCA,
        GENERAL_SENSOR_SETTINGS_CHANGE = 0xCB,
        SENSOR_GLUCOSE_READINGS = 0xCC,
        SENSOR_GLUCOSE_GAP = 0xCD,
        GLUCOSE_SENSOR_CHANGE = 0xCE,
        SENSOR_CALIBRATION_REJECTED = 0xCF,
        SENSOR_ALERT_SILENCE_STARTED = 0xD0,
        SENSOR_ALERT_SILENCE_ENDED = 0xD1,
        OLD_LOW_SENSOR_WARNING_LEVELS = 0xD2,
        NEW_LOW_SENSOR_WARNING_LEVELS = 0xD3,
        OLD_HIGH_SENSOR_WARNING_LEVELS = 0xD4,
        NEW_HIGH_SENSOR_WARNING_LEVELS = 0xD5,
        SENSOR_GLUCOSE_READINGS_EXTENDED = 0xD6,
        NORMAL_BOLUS_DELIVERED = 0xDC,
        SQUARE_BOLUS_DELIVERED = 0xDD,
        DUAL_BOLUS_PART_DELIVERED = 0xDE,
        CLOSED_LOOP_TRANSITION = 0xDF

    }
}
