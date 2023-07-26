import "./ReviewForm.css";
import Button from "../Button/Button";
import Slider from "../Slider/Slider";
import TextArea from "../Textarea/Textarea";
import React, { useState, useEffect } from "react";

type OnSaveFunction = (text: string, averageValue: number) => void;

type ReviewFormProps = {
  onSave: OnSaveFunction;
};

function ReviewForm({ onSave }: ReviewFormProps) {
  const [sliderValues, setSliderValues] = useState<number[]>([1, 1, 1, 1, 1]);
  const [averageValue, setAverageValue] = useState(1);
  const [textValue, setTextValue] = useState("");

  const handleSliderChange = (index: number, value: number) => {
    const updatedValues = [...sliderValues];
    updatedValues[index] = value;
    setSliderValues(updatedValues);
  };

  const handleTextChange = (value: string) => {
    setTextValue(value);
  };

  const calculateAverage = (values: number[]) => {
    const totalSum = values.reduce((acc, value) => acc + value, 0);
    return totalSum / values.length;
  };

  useEffect(() => {
    const average = calculateAverage(sliderValues);
    setAverageValue(average);
  }, [sliderValues]);

  const handleSave = () => {
    onSave(textValue, averageValue);
  };

  return (
    <div className="review-form__box">
      <p className="review-form__mark">{calculateAverage(sliderValues).toFixed(1)}/5</p>
      <p className="review-form__text">How nice was my reply?</p>       
      <Slider text="Cleanliness" onChange={(value) => handleSliderChange(0, value)} />
      <Slider text="Customer Service" onChange={(value) => handleSliderChange(1, value)} />
      <Slider text="Speed" onChange={(value) => handleSliderChange(2, value)} />
      <Slider text="Location" onChange={(value) => handleSliderChange(3, value)} />
      <Slider text="Facilities" onChange={(value) => handleSliderChange(4, value)} /> 
      <div className="review-form__text-area-button">
        <TextArea onChange={handleTextChange} />
        <Button onClick={handleSave} className="review-form__button">Send</Button>
      </div>
    </div>
  );
}

export default ReviewForm;