
qsort :: Ord a => [a]->[a]
qsort [] = []
qsort (x:xs) = ys ++ [x] ++ zs
                where
                    ys = [a|a<-xs,a<=x]
                    zs = [b|b<-xs,b>x]

