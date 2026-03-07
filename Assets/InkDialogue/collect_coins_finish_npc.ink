=== collectCoinsFinish ===
{ CollectCoinsQuestState:
    - "FINISHED": -> finished
    - else: -> default
}

= finished
Thank you!
-> END

= default
Hmm? What do you want?
* [Nothing much, just wanted to say hiiii!!.]
    -> END
* { CollectCoinsQuestState == "CAN_FINISH" } [Here are some coins.]
    ~ FinishQuest(CollectCoinsQuestId)
    Oh? This trash is for me? Thank you so much :3! I will also open the border for you since you helped me get some scrap that I was really hungry for.
-> END