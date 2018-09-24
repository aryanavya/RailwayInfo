# Rail Bot Sample With Luis

This is simple Chatbot for Railway Information. It gives information like PNR status, live train status, fair train enquiry etc.

To check PNR status type message for example “Check pnr 9874563210” and PNR number must be valid.Then bot displays message with information train name, train number, date, starting station name and station code, destination station name and station code, number of passengers and their PNR status.

For live train status type message with train name or train number for example “location of chennai express” or “location of 11007”. Then bot displays message with information position of train.

For fair train enquiry type message with starting station code and destination station code for example “find trains from cstm to pune” or “search railways from kkw to ddr”.Then bot reply with list of all trains from starting station to destination station for present day. List contains train number, train name and time.


### Code Highlights

One of the key problems in human-computer interactions is the ability of the computer to understand what a person wants, and to find the pieces of information that are relevant to their intent. In the LUIS application, you will bundle together the intents and entities that are important to your task. Read more about [Planning an Application](https://www.microsoft.com/cognitive-services/en-us/LUIS-api/documentation/Plan-your-app) in the LUIS Help Docs.
Check out the use of LuisIntent attributes decorating [RootLuisDialog](Dialogs/RootLuisDialog.cs#L41) methods to handle LUIS Intents, for instance `[LuisIntent("SearchRailways")]`.

````C#
[LuisIntent("SearchRAilways")]
public async Task Search(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
{
    ...
}
````

Each intent handler method accepts the `IDialogContext`, the original incoming `IMessageActivity` message and the `LuisResult` including the matching Intents and Entities for the LUIS query.


### Outcome

You will see the following in the Bot Framework Emulator when opening and running the sample solution.

![Sample Outcome](images/outcome1.png)
![Sample Outcome](images/outcome.png)


# RailBOt
# RailBOt
# RailBot
# RailBot
# RailBot
# csharp
# csharp
# csharp
# csharp
# csharp
# csharp
# RailBot
# RailBot
# RailBot
# RailBot
# RailBot
# RailBot
