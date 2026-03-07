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
Come back when your experienced (I need level 2).
-> END

= canStart
Will you collect 5 scraps for my bro over there? They are over at the other side on the right. 
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