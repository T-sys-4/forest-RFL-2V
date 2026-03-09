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
// this quest cannot actually happen, but something is here anyway
Come back when your experienced by first collecting motherboards (I need level 5) 
-> END

= canStart
Will you collect 20 metal scraps for my bro over there? They are on my right.
* [Yes]
    ~ StartQuest(CollectCoinsQuestId)
    Great!
* [No]
    Oh, alright then. Come back if you want your hands dirty.
- -> END

= inProgress
How is the scap collection going?
-> END

= canFinish
Oh? Have you collected the scrap:>? Go give them to my friend over there and he will give you a big reward andddd...open the border for you too.
-> END

= finished
Thank you for collecting those scraps :3!
-> END