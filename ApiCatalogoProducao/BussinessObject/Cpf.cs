using System;
using System.Collections.Generic;
using System.Text;

namespace ApiCatalogoProducao.BusinessObject
{
    public sealed class Cpf
    {
        public static Cpf FromString(string value)
        {
            return new Cpf(value);
        }

        private static string Normalize(string value)
        {
            return value.Replace(".", "").Replace("-", "");
        }

        public static bool IsValid(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = Normalize(cpf.Trim());
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            var result = cpf.EndsWith(digito);
            return result;
        }

        private const int DefaultSize = 11;

        public string Value { get; private set; }

        private Cpf(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value));
            }
            if (!IsValid(value))
            {
                throw new ArgumentException($"Invalid number [{value}]");
            }
            Value = Normalize(value);
        }

        public override bool Equals(object obj)
        {
            return obj is Cpf number &&
                   Value == number.Value;
        }

        public override int GetHashCode()
        {
            return -1937169414 + EqualityComparer<string>.Default.GetHashCode(Value);
        }

        public string FormatWithZero()
        {
            if (Value.Length < DefaultSize)
            {
                return Value.PadLeft(DefaultSize, '0');
            }
            return Value;
        }
    }
}
