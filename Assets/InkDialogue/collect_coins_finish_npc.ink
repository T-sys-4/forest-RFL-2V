=== collectCoinsFinish ===
{ CollectCoinsQuestState:
    - "FINISHED": -> finished
    - else: -> default
}

= finished
Hvala!
-> END

= default
Hm? Kaj želiš?
* [Nič, mislim.]
    -> END
* { CollectCoinsQuestState == "CAN_FINISH" } [Tukaj je nekaj kovancev.]
    ~ FinishQuest(CollectCoinsQuestId)
    O? Ti kovanci so zame? Hvala!
-> END
