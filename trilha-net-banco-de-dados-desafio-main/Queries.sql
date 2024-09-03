use Filmes;

-- 1- Buscar o nome e ano dos filmes
select Nome, Ano from filmes;

-- 2 - Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano
select Nome, Ano from filmes order by Ano;

-- 3 - Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a duração
select * from filmes where Nome = 'De volta para o futuro';

-- 4 - Buscar os filmes lançados em 1997
select * from filmes where Ano = 1997;

-- 5 - Buscar os filmes lançados APÓS o ano 2000
select * from filmes where Ano > 2000;

-- 6 - Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente
select * from filmes 
where Duracao > 100 and Duracao < 150
order by Duracao;

-- 7 - Buscar a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela quantidade em ordem decrescente
select Ano, count(*) Quantidade from filmes 
group by Ano
order by Quantidade desc;

-- 8 - Buscar os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome
select PrimeiroNome, UltimoNome from atores where Genero = 'M';

-- 9 - Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome
select PrimeiroNome, UltimoNome from atores where Genero = 'F' order by PrimeiroNome;

-- 10 - Buscar o nome do filme e o gênero
select a.Nome, c.Genero from filmes a
inner join FilmesGenero b on a.Id = b.IdFilme
inner join Generos c on c.Id = b.IdGenero;

-- 11 - Buscar o nome do filme e o gênero do tipo "Mistério"
select a.Nome, c.Genero from filmes a
inner join FilmesGenero b on a.Id = b.IdFilme 
inner join Generos c on c.Id = b.IdGenero and c.Genero = 'Mistério';

-- 12 - Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel
select a.Nome, c.PrimeiroNome, c.UltimoNome, b.Papel from filmes a
inner join ElencoFilme b on a.Id = b.IdFilme 
inner join Atores c on c.Id = b.IdAtor;
