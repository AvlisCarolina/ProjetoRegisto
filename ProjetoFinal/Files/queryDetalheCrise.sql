SELECT crises.idCrise, crises.idPaciente, pacientes.nome, dataHora, duracaoCrise, nivelAnsiedade, nivelDepressao, 
descricaoSituacao, pensamentosImagens, sensa.idSensacao, senti.idSentimento, sentimentos.descricao, sensacoes.descricao FROM crises
    JOIN pacientes ON crises.idPaciente = pacientes.idPaciente
    JOIN criseListaSentimentos AS senti ON crises.idCrise = Senti.idCrise
    JOIN criseListaSensacoes AS sensa ON crises.idCrise = sensa.idCrise
    JOIN sentimentos ON sentimentos.idSentimento = senti.idSentimento
    JOIN sensacoes ON sensacoes.idSensacao = sensa.idSensacao
        WHERE pacientes.idUtilizador = 3;