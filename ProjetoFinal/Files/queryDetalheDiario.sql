SELECT diario.idDiario, diario.idPaciente, pacientes.nome, data, sono, alimentacao, atividadeFisica, convivioSocial, 
detalhes, crise, sensa.idSensacao, senti.idSentimento, sentimentos.descricao, sensacoes.descricao FROM diario
    JOIN pacientes ON diario.idPaciente = pacientes.idPaciente
    JOIN DiarioListaSentimentos AS senti ON diario.idDiario = Senti.idDiario
    JOIN DiarioListaSensacoes AS sensa ON diario.idDiario = sensa.idDiario
    JOIN sentimentos ON sentimentos.idSentimento = senti.idSentimento
    JOIN sensacoes ON sensacoes.idSensacao = sensa.idSensacao
        WHERE pacientes.idUtilizador = 3