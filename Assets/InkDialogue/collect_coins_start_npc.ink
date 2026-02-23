=== collectCoinsStart ===
{ CollectCoinsQuestState :
    - "REQUIREMENTS_NOT_MET": -> requirementsNotMet
    - "CAN_START": -> canStart
    - "IN_PROGRESS": -> inProgress
    - "CAN_FINISH": -> canFinish
    - "FINISHED": -> finished
    - else: -> END
}

= requirementsNotMet
// za to nalogo ni mogoče, ampak vseeno nekaj tukaj
Vrni se, ko boš dosegel nekoliko višjo raven.
-> END

= canStart
Ali boš zbral 5 kovancev in jih prinesel mojemu prijatelju tamle?
* [Da]
    ~ StartQuest(CollectCoinsQuestId)
    Super!
* [Ne]
    Oh, v redu potem. Vrni se, če si premisliš.
- -> END

= inProgress
Kako napreduje zbiranje tistih kovancev?
-> END

= canFinish
O? Si zbral kovance? Pojdi jih dat mojemu prijatelju tamle in dal ti bo nagrado!
-> END

= finished
Hvala, ker si zbral tiste kovance!
-> END
