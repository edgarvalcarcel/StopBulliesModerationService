from fastapi import FastAPI

app = FastAPI()

@app.post("/analyze")
def analyze():
    return {"risk_level": "low"}