  static byte[] rotate(byte[] p, int N) => pattern((x, y) => p[N - 1 - y + x * N], N);
        static byte[] reflect(byte[] p, int N) => pattern((x, y) => p[N - 1 - x + y * N], N);

        static long hash(byte[] p, int C)
        {
            long result = 0, power = 1;
            for (int i = 0; i < p.Length; i++)
            {
                result += p[p.Length - 1 - i] * power;
                power *= C;
            }
            return result;
        };  
for (int k = 0; k < symmetry; k++)
                {
                    byte[] p = ps[k];
                    long h = hash(p, C);
                    if (patternIndices.TryGetValue(h, out int index)) weightList[index] = weightList[index] + 1;
                    else
                    {
                        patternIndices.Add(h, weightList.Count);
                        weightList.Add(1.0);
                        patterns.Add(p);
                    }
                }
            }
