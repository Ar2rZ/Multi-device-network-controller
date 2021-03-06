﻿namespace NetworkController.Client.Logic.DataTypes.Interfaces
{
    public interface IDeltaGestureState : IGestureState, IMeasuredDeltaState
    {
        /// <summary>
        /// Last intensity value
        /// </summary>
        int LastIntensity { get; set; }

        /// <summary>
        /// True if the gesture was detected last update
        /// </summary>
        bool DetectedLastTick { get; set; }

        /// <summary>
        /// True if the gesture was detected this update
        /// </summary>
        bool DetectedThisTick { get; set; }

    }
}
