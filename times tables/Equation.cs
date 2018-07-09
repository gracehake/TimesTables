using System;
using System.Collections.Generic;

namespace times_tables
{
    public class Equation
    {
        public string Text { get; }
        public bool IsCorrect { get; private set; }

        private int _result;
        private int _number1;
        private int _number2;
        private DateTime _startTime;
        private DateTime _attemptStartTime;
        private double _timeToSolve;
        private readonly List<Attempt> _attempts;

        public Equation()
        {
            _attempts = new List<Attempt>();
            IsCorrect = false;
            RollDice();
            Text = $"{_number1} x {_number2}";
            _startTime = DateTime.Now;
            _attemptStartTime = _startTime;
        }

        public void MakeAttempt(int suggestedResult)
        {
            IsCorrect = suggestedResult == _result;
            if (IsCorrect)
            {
                _timeToSolve = (DateTime.Now - _startTime).TotalSeconds;
            }
            _attempts.Add(
                new Attempt
                {
                    Number1 = _number1,
                    Number2 = _number2,
                    Correct = IsCorrect,
                    Suggestion = suggestedResult,
                    Seconds = (DateTime.Now - _attemptStartTime).TotalSeconds
                });
            _attemptStartTime = DateTime.Now;
        }

        public string Statistics()
        {
            var attemptsString = string.Empty;
            foreach (var attempt in _attempts)
            {
                attemptsString = attemptsString + $"{attempt.Suggestion} ({attempt.Seconds}),";
            }
            return $"{DateTime.Now:G}: \t{Text} = {_result} \t{_attempts.Count} \t{_timeToSolve} \t{attemptsString}";
        }

        private void RollDice()
        {
            var random = new Random();
            _number1 = random.Next(1, 16);
            _number2 = random.Next(1, 16);
            _result = _number1 * _number2;
            _startTime = DateTime.Now;
        }
    }
}