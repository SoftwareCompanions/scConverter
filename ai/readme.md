# scConverter AI Schema

This directory contains the **AI-readable tool schema** for **scConverter**.

The schema is published as a YAML file optimized for **OpenAI function / tool calling** and is generated from the official **scConverter IDL**, with additional documentation merged from the PDF SDK documentation.

Think of this as the **authoritative contract** that AI agents should use when generating scConverter code.

---

## What this is

- A machine-readable description of **all scConverter methods and properties**
- Derived from:
  - `scConverter.idl` (authoritative signatures, types, DISPIDs)
  - `scConverter.pdf` (human-readable descriptions)
- Structured to match **OpenAI function tool schemas** (JSON Schema–based)

This allows AI systems to:
- know exactly which scConverter operations exist
- understand required parameters and types
- generate correct code (COM, wrappers, or HTTP adapters)
- avoid hallucinating non-existent methods

---

## Files

- `scconverter.yaml`  
  The **current AI schema** for scConverter (OpenAI-compatible).

> **Important:**  
> This YAML is not executable by itself.  
> It must be loaded by an AI agent, tool framework, or application that knows how to call scConverter (e.g. via COM on Windows).

---

## How to use this with AI (ChatGPT, OpenAI, agents)

### 1. Reference the schema explicitly
AI models do **not** automatically discover this file.  
You must provide the link or load it programmatically.

**Canonical URL:**

https://raw.githubusercontent.com/SoftwareCompanions/scConverter/master/ai/scconverter.yaml


