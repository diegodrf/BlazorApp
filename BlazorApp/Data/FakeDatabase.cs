namespace BlazorApp.Data
{
    public class FakeDatabase
    {
        private readonly Dictionary<string, object> _keyValuePairs = new();

        public void SetValue<T>(string key, T value)
        {
            ArgumentNullException.ThrowIfNull(value);
            _keyValuePairs[key] = value;
        }

        public T GetValueOrDefault<T>(string key, T defaultValue)
        {
            if(_keyValuePairs.TryGetValue(key, out var value))
            {
                return (T)value;
            }
            
            return defaultValue;
        }
    }
}
