/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID ONMUSICATTACKEVENTHANDLER = 3863509023U;
        static const AkUniqueID ONMUSICCHILLEVENTHANDLER = 1336557311U;
        static const AkUniqueID ONMUSICGAMEOVEREVENTHANDLER = 3600875727U;
        static const AkUniqueID ONMUSICLAUNCHEVENTHANDLER = 1763420906U;
        static const AkUniqueID ONMUSICMENUEVENTHANDLER = 2667605526U;
        static const AkUniqueID ONMUSICONEMINLEFTEVENTHANDLER = 4278809340U;
        static const AkUniqueID ONMUSICVICTORYEVENTHANDLER = 3218507479U;
        static const AkUniqueID PLAYER_FOOTSTEP = 2453392179U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace MUSIC
        {
            static const AkUniqueID GROUP = 3991942870U;

            namespace STATE
            {
                static const AkUniqueID GAME_OVER = 1432716332U;
                static const AkUniqueID GAMEPLAY_1MIN_LEFT = 2017070741U;
                static const AkUniqueID GAMEPLAY_ATTACK = 2990406544U;
                static const AkUniqueID GAMEPLAY_CHILL = 3295880750U;
                static const AkUniqueID MENU = 2607556080U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID VICTORY = 2716678721U;
            } // namespace STATE
        } // namespace MUSIC

    } // namespace STATES

    namespace SWITCHES
    {
        namespace FOOTSTEP
        {
            static const AkUniqueID GROUP = 1866025847U;

            namespace SWITCH
            {
                static const AkUniqueID RUN = 712161704U;
                static const AkUniqueID WALK = 2108779966U;
            } // namespace SWITCH
        } // namespace FOOTSTEP

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID BPM = 798609784U;
        static const AkUniqueID MOVESPEED = 1086842483U;
    } // namespace GAME_PARAMETERS

    namespace TRIGGERS
    {
        static const AkUniqueID GAME_OVER = 1432716332U;
    } // namespace TRIGGERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID ALL = 1100754030U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID NEW_AUXILIARY_BUS = 373392551U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
