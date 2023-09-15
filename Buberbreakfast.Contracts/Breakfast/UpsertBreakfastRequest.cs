namespace BuberBreakfast.Contracts.Breakfast;

public record UpsertBreakfastRequest(
    String Name,
    String Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);
