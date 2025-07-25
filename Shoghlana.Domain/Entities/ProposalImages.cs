﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Shoghlana.Domain.Entities;
public class ProposalImages
{
    public int Id { get; set; }

    [ForeignKey("Proposal")]
    public int ProposalId { get; set; }

    public Proposal? Proposal { get; set; }

    public byte[] Image { get; set; }
}
