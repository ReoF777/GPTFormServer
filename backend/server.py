from fastapi import FastAPI
import uvicorn
from openai import OpenAI
from pydantic import BaseModel

app = FastAPI()

key = "APIキー"
client = OpenAI(api_key = key)

class GPTRequest(BaseModel):
    prompt: str

@app.post("/gpt/")
async def get_gpt_response(request: GPTRequest):
    print(request.prompt)
    try:
        responses = client.chat.completions.create(
            messages=[
                {
                    "role": "user",
                    "content": request.prompt
                }
            ],
            model = "gpt-3.5-turbo",
        )
        print(responses)
        return {"Response": responses.choices[0].message.content}

    except Exception as e:
        return {"error": str(e)}

if __name__ == "__main__":
    uvicorn.run(app, host="127.0.0.1", port=8000, log_level="debug")