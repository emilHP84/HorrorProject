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
        static const AkUniqueID ONAMBIANCESALLEENTREPOTEVENTHANDLER = 176453890U;
        static const AkUniqueID ONAMBIANCESALLEGARDIENEVENTHANDLER = 948802671U;
        static const AkUniqueID ONAMBIANCESALLEPRINCIPALEEVENTHANDLER = 2964699108U;
        static const AkUniqueID ONCAPTEURCARDIAQUEEVENTHANDLER = 3968532517U;
        static const AkUniqueID ONCATETATEVENTHANDLER = 872696306U;
        static const AkUniqueID ONCATFOOTSTEPWALKEVENTHANDLER = 864079451U;
        static const AkUniqueID ONDISJONCTEURBROKENEVENTHANDLER = 3618294761U;
        static const AkUniqueID ONDISJONCTEURIDLEEVENTHANDLER = 2654241884U;
        static const AkUniqueID ONDISJONCTEURREPAIREVENTHANDLER = 2440927333U;
        static const AkUniqueID ONLIGHTIDLEEVENTHANDLER = 426425284U;
        static const AkUniqueID ONLIGHTOFFEVENTHANDLER = 871364757U;
        static const AkUniqueID ONLIGHTONEVENTHANDLER = 539183377U;
        static const AkUniqueID ONMUSICATTACKEVENTHANDLER = 3863509023U;
        static const AkUniqueID ONMUSICCHILLEVENTHANDLER = 1336557311U;
        static const AkUniqueID ONMUSICGAMEOVEREVENTHANDLER = 3600875727U;
        static const AkUniqueID ONMUSICLAUNCHEVENTHANDLER = 1763420906U;
        static const AkUniqueID ONMUSICMENUEVENTHANDLER = 2667605526U;
        static const AkUniqueID ONMUSICONEMINLEFTEVENTHANDLER = 4278809340U;
        static const AkUniqueID ONMUSICVICTORYEVENTHANDLER = 3218507479U;
        static const AkUniqueID ONPLAYERFOOTSTEPEVENTHANDLER = 2180450423U;
        static const AkUniqueID ONPOUPEEETATEVENTHANDLER = 2534268164U;
        static const AkUniqueID ONPOUPEEFOOTSTEPEVENTHANDLER = 1822394066U;
        static const AkUniqueID ONRABBITETATEVENTHANDLER = 3039266970U;
        static const AkUniqueID ONRABBITFOOTSTEPEVENTHANDLER = 162255504U;
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
        namespace CAT_ETAT
        {
            static const AkUniqueID GROUP = 3792655162U;

            namespace SWITCH
            {
                static const AkUniqueID ATTACK = 180661997U;
                static const AkUniqueID IDLE = 1874288895U;
            } // namespace SWITCH
        } // namespace CAT_ETAT

        namespace CAT_FOOTSTEP
        {
            static const AkUniqueID GROUP = 1812327176U;

            namespace SWITCH
            {
                static const AkUniqueID RUN = 712161704U;
                static const AkUniqueID WALK = 2108779966U;
            } // namespace SWITCH
        } // namespace CAT_FOOTSTEP

        namespace PLAYER_FOOTSTEP
        {
            static const AkUniqueID GROUP = 2453392179U;

            namespace SWITCH
            {
                static const AkUniqueID RUN = 712161704U;
                static const AkUniqueID WALK = 2108779966U;
            } // namespace SWITCH
        } // namespace PLAYER_FOOTSTEP

        namespace POUPEE_ETAT
        {
            static const AkUniqueID GROUP = 1367822422U;

            namespace SWITCH
            {
                static const AkUniqueID ACTIVATE = 4166407614U;
                static const AkUniqueID ATTACK = 180661997U;
                static const AkUniqueID KILL = 2030840469U;
                static const AkUniqueID RESEARCH = 3895945778U;
            } // namespace SWITCH
        } // namespace POUPEE_ETAT

        namespace POUPEE_FOOTSTEP
        {
            static const AkUniqueID GROUP = 3624582108U;

            namespace SWITCH
            {
                static const AkUniqueID RUN = 712161704U;
                static const AkUniqueID WALK = 2108779966U;
            } // namespace SWITCH
        } // namespace POUPEE_FOOTSTEP

        namespace RABBIT_ETAT
        {
            static const AkUniqueID GROUP = 4253254304U;

            namespace SWITCH
            {
                static const AkUniqueID FUITE = 2218847794U;
                static const AkUniqueID GRIGNOTE = 3827887798U;
            } // namespace SWITCH
        } // namespace RABBIT_ETAT

        namespace RABBIT_FOOTSTEP
        {
            static const AkUniqueID GROUP = 743134326U;

            namespace SWITCH
            {
                static const AkUniqueID RUN = 712161704U;
                static const AkUniqueID WALK = 2108779966U;
            } // namespace SWITCH
        } // namespace RABBIT_FOOTSTEP

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID BPM = 798609784U;
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
