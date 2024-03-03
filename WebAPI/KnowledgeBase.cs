﻿using System;
using System.Collections.Generic;

namespace WebAPI;

/// <summary>
/// TS.ActionType=Schema;TS.EntitySchema.UId={0326868C-CE5E-4934-8F1F-178801BFE6C3};TS.EntitySchema.Kind=General;TS.EntitySchema.ParentSchemaUId={1BAB9DCF-17D5-49F8-9536-8E0064F1DCE0};TS.EntitySchema.Caption=en-US|Knowledge base article,ru-RU|Статья базы знаний;TS.EntitySchemaName=KnowledgeBase;
/// TS.ConstraintName=PK3YeSki1KPs39ZhbFyZr0emwk4;TS.EntitySchemaColumn.UId={AE0E45CA-C495-4FE7-A39D-3AB7278E1617};TS.ActionType=PrimaryKey;
/// TS.EntitySchemaIndex.UId={A96683CF-39CC-4FBF-B4D1-ED823F1142CB};TS.IndexName=WbNameIndex;TS.IsColumnIndex=False;TS.ActionType=Index;
/// </summary>
public partial class KnowledgeBase
{
    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={AE0E45CA-C495-4FE7-A39D-3AB7278E1617};TS.EntitySchemaColumn.DataValueType=Guid;TS.EntitySchemaColumn.ReferenceSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Id,ru-RU|Id;TS.EntitySchemaColumn.CreatedInSchemaUId={1BAB9DCF-17D5-49F8-9536-8E0064F1DCE0};TS.ColumnName=Id;TS.ActionType=Column;
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={E80190A5-03B2-4095-90F7-A193A960ADEE};TS.EntitySchemaColumn.DataValueType=DateTime;TS.EntitySchemaColumn.ReferenceSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Created on,ru-RU|Дата создания;TS.EntitySchemaColumn.CreatedInSchemaUId={1BAB9DCF-17D5-49F8-9536-8E0064F1DCE0};TS.ColumnName=CreatedOn;TS.ActionType=Column;
    /// TS.ConstraintName=DF66in6BmJAz41apFKkTCNJtqDCrQ;TS.EntitySchemaColumn.UId={E80190A5-03B2-4095-90F7-A193A960ADEE};TS.ActionType=DefValue;
    /// </summary>
    public DateTime? CreatedOn { get; set; }

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={EBF6BB93-8AA6-4A01-900D-C6EA67AFFE21};TS.EntitySchemaColumn.DataValueType=Lookup;TS.EntitySchemaColumn.ReferenceSchemaUId={16BE3651-8FE2-4159-8DD0-A803D4683DD3};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Created by,ru-RU|Создал;TS.EntitySchemaColumn.CreatedInSchemaUId={1BAB9DCF-17D5-49F8-9536-8E0064F1DCE0};TS.ColumnName=CreatedById;TS.ActionType=Column;
    /// TS.EntitySchemaIndex.UId={EBF6BB93-8AA6-4A01-900D-C6EA67AFFE21};TS.IndexName=IIyj9qoMurwrczy0RBdF98gD9OFU;TS.IsColumnIndex=True;TS.ActionType=Index;
    /// </summary>
    public Guid? CreatedById { get; set; }

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={9928EDEC-4272-425A-93BB-48743FEE4B04};TS.EntitySchemaColumn.DataValueType=DateTime;TS.EntitySchemaColumn.ReferenceSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Modified on,ru-RU|Дата изменения;TS.EntitySchemaColumn.CreatedInSchemaUId={1BAB9DCF-17D5-49F8-9536-8E0064F1DCE0};TS.ColumnName=ModifiedOn;TS.ActionType=Column;
    /// TS.EntitySchemaIndex.UId={9928EDEC-4272-425A-93BB-48743FEE4B04};TS.IndexName=IhQsUipn9pFdVN6lHo0avF2dVLkI;TS.IsColumnIndex=True;TS.ActionType=Index;
    /// TS.ConstraintName=DFHlnCwdZGPq7Rfx5tbKm9Ecqy8dg;TS.EntitySchemaColumn.UId={9928EDEC-4272-425A-93BB-48743FEE4B04};TS.ActionType=DefValue;
    /// </summary>
    public DateTime? ModifiedOn { get; set; }

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={3015559E-CBC6-406A-88AF-07F7930BE832};TS.EntitySchemaColumn.DataValueType=Lookup;TS.EntitySchemaColumn.ReferenceSchemaUId={16BE3651-8FE2-4159-8DD0-A803D4683DD3};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Modified by,ru-RU|Изменил;TS.EntitySchemaColumn.CreatedInSchemaUId={1BAB9DCF-17D5-49F8-9536-8E0064F1DCE0};TS.ColumnName=ModifiedById;TS.ActionType=Column;
    /// TS.EntitySchemaIndex.UId={3015559E-CBC6-406A-88AF-07F7930BE832};TS.IndexName=IvCMWzpHq0qCvIesDzAxWxmTUc;TS.IsColumnIndex=True;TS.ActionType=Index;
    /// </summary>
    public Guid? ModifiedById { get; set; }

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={654D83A5-23A0-4555-8048-EEC76CFC8F4B};TS.EntitySchemaColumn.DataValueType=MediumText;TS.EntitySchemaColumn.ReferenceSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Name,ru-RU|Название;TS.EntitySchemaColumn.CreatedInSchemaUId={0326868C-CE5E-4934-8F1F-178801BFE6C3};TS.ColumnName=Name;TS.ActionType=Column;
    /// TS.ConstraintName=DFMwqcXQpxs45RDtXZ0TLpS2Gf7wE;TS.EntitySchemaColumn.UId={654D83A5-23A0-4555-8048-EEC76CFC8F4B};TS.ActionType=DefValue;
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={FE374374-3A0F-4B14-9148-8B95E3320249};TS.EntitySchemaColumn.DataValueType=MaxSizeText;TS.EntitySchemaColumn.ReferenceSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Resolution,ru-RU|Решение;TS.EntitySchemaColumn.CreatedInSchemaUId={0326868C-CE5E-4934-8F1F-178801BFE6C3};TS.ColumnName=Notes;TS.ActionType=Column;
    /// TS.ConstraintName=DFjOUvp6miIcvqQAGpjMWHuE6Ksg;TS.EntitySchemaColumn.UId={FE374374-3A0F-4B14-9148-8B95E3320249};TS.ActionType=DefValue;
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={83D9D3C9-90DF-486E-A7C9-CDC7E90EC6B3};TS.EntitySchemaColumn.DataValueType=ShortText;TS.EntitySchemaColumn.ReferenceSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Code,ru-RU|Код;TS.EntitySchemaColumn.CreatedInSchemaUId={0326868C-CE5E-4934-8F1F-178801BFE6C3};TS.ColumnName=Code;TS.ActionType=Column;
    /// TS.ConstraintName=DFFzkGV59po0mPP6bZPvjchSa8PU;TS.EntitySchemaColumn.UId={83D9D3C9-90DF-486E-A7C9-CDC7E90EC6B3};TS.ActionType=DefValue;
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={C730359E-6048-4AFE-AB8A-FE8097A9DA16};TS.EntitySchemaColumn.DataValueType=MaxSizeText;TS.EntitySchemaColumn.ReferenceSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Tags,ru-RU|Теги;TS.EntitySchemaColumn.CreatedInSchemaUId={0326868C-CE5E-4934-8F1F-178801BFE6C3};TS.ColumnName=Keywords;TS.ActionType=Column;
    /// TS.ConstraintName=DFcCNwJ2AlgocdcA542FKpGG6PvYQ;TS.EntitySchemaColumn.UId={C730359E-6048-4AFE-AB8A-FE8097A9DA16};TS.ActionType=DefValue;
    /// </summary>
    public string? Keywords { get; set; }

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={33DB271F-4440-457B-A15C-05F6E83AD8A8};TS.EntitySchemaColumn.DataValueType=Lookup;TS.EntitySchemaColumn.ReferenceSchemaUId={9D744E43-11B0-4811-BFE1-6350F1D100C3};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Type,ru-RU|Тип;TS.EntitySchemaColumn.CreatedInSchemaUId={0326868C-CE5E-4934-8F1F-178801BFE6C3};TS.ColumnName=TypeId;TS.ActionType=Column;
    /// TS.EntitySchemaIndex.UId={33DB271F-4440-457B-A15C-05F6E83AD8A8};TS.IndexName=Ik7swTRVpojLU67VNDz1C4bsiieo;TS.IsColumnIndex=True;TS.ActionType=Index;
    /// TS.ConstraintName=FKCaxZHsgHwYUhLh5L4F4kQmY0eCY;TS.EntitySchemaColumn.UId={33DB271F-4440-457B-A15C-05F6E83AD8A8};TS.ActionType=ForeignKey;
    /// </summary>
    public Guid? TypeId { get; set; }

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={3FABD836-6A53-4D8D-9069-6DF88D9DAE1E};TS.EntitySchemaColumn.DataValueType=Integer;TS.EntitySchemaColumn.ReferenceSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Active processes,ru-RU|Активные процессы;TS.EntitySchemaColumn.CreatedInSchemaUId={1BAB9DCF-17D5-49F8-9536-8E0064F1DCE0};TS.ColumnName=ProcessListeners;TS.ActionType=Column;
    /// TS.ConstraintName=DFZLQI5b5DQNDrLHMhjt6mcOt2nQ;TS.EntitySchemaColumn.UId={3FABD836-6A53-4D8D-9069-6DF88D9DAE1E};TS.ActionType=DefValue;
    /// </summary>
    public int? ProcessListeners { get; set; }

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={FDE3D1EB-6629-4A28-9621-DAA6C6EB4C1F};TS.EntitySchemaColumn.DataValueType=Integer;TS.EntitySchemaColumn.ReferenceSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Views,ru-RU|Количество просмотров;TS.EntitySchemaColumn.CreatedInSchemaUId={0326868C-CE5E-4934-8F1F-178801BFE6C3};TS.ColumnName=ViewsCount;TS.ActionType=Column;
    /// TS.ConstraintName=DFGeSTKzjTlhClrubtKKmWgUNT30k;TS.EntitySchemaColumn.UId={FDE3D1EB-6629-4A28-9621-DAA6C6EB4C1F};TS.ActionType=DefValue;
    /// </summary>
    public int? ViewsCount { get; set; }

    /// <summary>
    /// TS.IsTemporary=False;TS.EntitySchemaColumn.UId={802D6477-8E01-4286-A563-084A2A4C4FF0};TS.EntitySchemaColumn.DataValueType=MaxSizeText;TS.EntitySchemaColumn.ReferenceSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.ReferenceValueListSchemaUId={00000000-0000-0000-0000-000000000000};TS.EntitySchemaColumn.Caption=en-US|Solution without HTML tags,ru-RU|Решение без HTML тегов;TS.EntitySchemaColumn.CreatedInSchemaUId={0326868C-CE5E-4934-8F1F-178801BFE6C3};TS.ColumnName=NotHtmlNote;TS.ActionType=Column;
    /// TS.ConstraintName=DFyVt7hAbMQlXv8ZiaCJr82G0qJJ4;TS.EntitySchemaColumn.UId={802D6477-8E01-4286-A563-084A2A4C4FF0};TS.ActionType=DefValue;
    /// </summary>
    public string? NotHtmlNote { get; set; }
}
