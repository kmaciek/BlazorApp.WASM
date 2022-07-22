namespace BlazorApp.WASM.Shared
{
    public record SortDetails<ItemType, FieldType>(SortDirection SortDirection, Func<ItemType, FieldType> KeySelector);
}