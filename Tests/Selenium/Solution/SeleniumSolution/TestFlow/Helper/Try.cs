namespace Six.Scs.Test.Helper
{
    public class Try
    {
        private int _maxNumberOfTries;

        /// <summary>
        ///     Initiates a helper which counts the numbers of tries
        /// </summary>
        /// <param name="maxNumberOfTries">how often a retry can be done</param>
        public Try(int maxNumberOfTries)
        {
            _maxNumberOfTries = maxNumberOfTries;
        }

        /// <summary>
        ///     This method is used after again() has returned false to check, if the limit has exceeded
        /// </summary>
        /// <returns>returns true if numbers of retries exceeded else false</returns>
        public bool TooOften()
        {
            return _maxNumberOfTries <= 0;
        }

        /// <summary>
        ///     Call of this method repeats a step if necessary and decreases counter
        /// </summary>
        /// <returns></returns>
        public bool Again()
        {
            _maxNumberOfTries--;
            return _maxNumberOfTries > 0;
        }
    }
}